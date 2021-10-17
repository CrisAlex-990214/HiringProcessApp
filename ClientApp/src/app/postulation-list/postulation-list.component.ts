import { ChangeDetectionStrategy, Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { HiringService } from '../hiring.service';
import { Postulation } from '../Models';

@Component({
  selector: 'app-postulation-list',
  templateUrl: './postulation-list.component.html',
  styleUrls: ['./postulation-list.component.css'],
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class PostulationListComponent implements OnInit{

  postulations$: Observable<Postulation[]>;
  
  constructor(private hiringService: HiringService) { }
  
  ngOnInit(): void {
    this.postulations$ = this.hiringService.getPostulations();
  }

}
