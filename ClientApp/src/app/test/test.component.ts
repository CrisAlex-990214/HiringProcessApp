import { Component, Input, OnInit } from '@angular/core';
import { Test } from '../Models';

@Component({
  selector: 'app-test',
  templateUrl: './test.component.html',
  styleUrls: ['./test.component.css']
})
export class TestComponent implements OnInit {

  @Input() tests: Test[];

  constructor() { }

  ngOnInit() {
  }

}
