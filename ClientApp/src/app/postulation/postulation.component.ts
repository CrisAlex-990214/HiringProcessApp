import { ChangeDetectionStrategy, Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { HiringService } from '../hiring.service';
import { Postulation, Qual, Test } from '../Models';

@Component({
  selector: 'app-postulation',
  templateUrl: './postulation.component.html',
  styleUrls: ['./postulation.component.css'],
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class PostulationComponent implements OnInit {

  postulation$: Observable<Postulation>;
  quals$: Observable<Qual[]>;

  constructor(private route: ActivatedRoute, private hiringService: HiringService) { }

  ngOnInit() {
    const id = +this.route.snapshot.params.id;

    this.postulation$ = this.hiringService.getPostulations().pipe(
      map(x=> x.find(y=> y.id == id)));
    this.quals$ = this.hiringService.getQuals();
  }

  getQualIdsSelected(tests: Test[]): number[]
  {
    return tests.map(x=> x.qual.id);
  }

}
