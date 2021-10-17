import { Component, Input, OnInit } from '@angular/core';
import { FinalStep } from '../Models';

@Component({
  selector: 'app-final-step',
  templateUrl: './final-step.component.html',
  styleUrls: ['./final-step.component.css']
})
export class FinalStepComponent implements OnInit {

  @Input() finalStep: FinalStep;

  constructor() { }

  ngOnInit() {
  }

}
