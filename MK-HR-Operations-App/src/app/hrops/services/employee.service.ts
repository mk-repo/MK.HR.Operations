import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Employee } from '../models/employee';
//import { BehaviorSubject } from 'rxjs/BehaviorSubject';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {

  //private _employees: BehaviorSubject<Employee[]>;

  private dataStore : {
    employees : Employee[]
  }

  constructor(private http : HttpClient) { 
    this.dataStore = { employees: [] };
  }

  loadAll() {
    const apiUrl = "";

    return this.http.get<Employee[]>(apiUrl)
    .subscribe(data => {
      this.dataStore.employees =  [ new Employee("aaa"), new Employee("bbbb")];
    }, error => {
      console.log(error);
    });
  }
}
