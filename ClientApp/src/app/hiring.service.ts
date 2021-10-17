import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Company, Postulation, Qual } from './Models';
import { map, shareReplay } from 'rxjs/operators'
import { InputFinalStep, InputTest } from './input-models';

@Injectable({
  providedIn: 'root'
})
export class HiringService {

  constructor(private http: HttpClient) { }

  apiUrl = 'https://hiringprocessapi.azurewebsites.net';

  getPostulations(): Observable<Postulation[]>
  {
    return this.http.get(`${this.apiUrl}/company`).pipe(
      map((x: Company) => x.postulations),
      shareReplay());
  }

  getQuals(): Observable<Qual[]>
  {
    return this.http.get(`${this.apiUrl}/test/quals`).pipe(shareReplay()) as Observable<Qual[]>;
  }

  addTest(test: InputTest): Observable<boolean>
  {
    return this.http.post(`${this.apiUrl}/test`, test) as Observable<boolean>;
  }

  addFinalStep(finalStep: InputFinalStep): Observable<boolean>
  {
    return this.http.post(`${this.apiUrl}/test/FinalStep`, finalStep) as Observable<boolean>;
  }
}
