import { Component, Input, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { Observable } from 'rxjs';
import { tap } from 'rxjs/operators';
import { HiringService } from '../hiring.service';
import { InputFinalStep } from '../input-models';

@Component({
  selector: 'app-final-step-edit',
  templateUrl: './final-step-edit.component.html',
  styleUrls: ['./final-step-edit.component.css'],
})
export class FinalStepEditComponent implements OnInit {

  @Input() postulationId: number;

  postFinalStep$: Observable<boolean>;
  success = false;

  finalStepForm = new FormGroup({
    avgScore: new FormControl('', [Validators.required,Validators.min(0), Validators.max(100)]),
    agreedSalary: new FormControl('', [Validators.required,Validators.min(3000000), Validators.max(6000000)]),
    startDate: new FormControl('', Validators.required),
  });

  constructor(private hiringService: HiringService) { }

  ngOnInit() {
  }

  onSubmit() {
    const finalStep = this.finalStepForm.value as InputFinalStep;
    finalStep.postulationId = this.postulationId;

    this.postFinalStep$ = this.hiringService.addFinalStep(finalStep).pipe(
      tap(x=> this.success = x)
    );
    setTimeout(() => {
      window.location.reload();
    }, 500);
  }

}
