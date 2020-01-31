import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Employee } from '../models/employee';
import { BehaviorSubject } from 'rxjs/internal/BehaviorSubject';
import { Observable } from 'rxjs/internal/observable';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {

  private _employees: BehaviorSubject<Employee[]>;

  private dataStore : {
    employees : Employee[]
  }

  constructor(private http : HttpClient) { 
    this.dataStore = { employees: [] };
    this._employees = new BehaviorSubject<Employee[]>([]);
  }

  get employees(): Observable<Employee[]> {
    return this._employees.asObservable();
  }

  loadAll() {
    const apiUrl = "";

    return this.http.get<Employee[]>(apiUrl)
    .subscribe(data => {
      this.dataStore.employees =  [ new Employee("aaa"), new Employee("bbbb")];
      //.next is used to publish data to all subscribing components.
      // To avoid exposing the internal datastore, Object.assign() is used to copy the datastore to another temp variable
      this._employees.next(Object.assign({}, this.dataStore.employees));
    }, error => {
      console.log(error);
    });
  }
}
