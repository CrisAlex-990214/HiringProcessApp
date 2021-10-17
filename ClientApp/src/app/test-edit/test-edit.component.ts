import { ChangeDetectorRef, Component, Input, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Observable } from 'rxjs';
import { map, tap } from 'rxjs/operators';
import { HiringService } from '../hiring.service';
import { InputTest } from '../input-models';
import { Qual } from '../Models';

@Component({
  selector: 'app-test-edit',
  templateUrl: './test-edit.component.html',
  styleUrls: ['./test-edit.component.css']
})
export class TestEditComponent implements OnInit {

  @Input() postulationId: number;
  @Input() qualIdsSelected: number[];

  quals$: Observable<Qual[]>; 
  postTest$: Observable<boolean>;

  success = false;

  TestForm = new FormGroup({
    QualId: new FormControl('', Validators.required),
    Score: new FormControl('', [Validators.required,Validators.min(0), Validators.max(100)]),
    Comment: new FormControl('', [Validators.required,Validators.maxLength(500)]),
  });

  constructor(private hiringService: HiringService, private cdRef: ChangeDetectorRef) { }

  ngOnInit() {
    this.quals$ = this.hiringService.getQuals().pipe(
        map(x=> x.filter(y=> !this.qualIdsSelected.includes(y.id))));
  }

  onSubmit() {
    const test = this.TestForm.value as InputTest;
    test.postulationId = this.postulationId;

    this.postTest$ = this.hiringService.addTest(test).pipe(
      tap(x=> this.success = x)
    );
    setTimeout(() => {
      window.location.reload();
    }, 500);
  }

}
