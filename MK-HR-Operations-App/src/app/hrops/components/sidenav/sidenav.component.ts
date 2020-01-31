import { Component, OnInit } from '@angular/core';
import { EmployeeService } from '../../services/employee.service';
import { Observable } from 'rxjs/internal/observable';
import { Employee } from '../../models/employee';

const WIDTH_OF_SMALL_SCREEN = 720;

@Component({
  selector: 'app-sidenav',
  templateUrl: './sidenav.component.html',
  styleUrls: ['./sidenav.component.css']
})
export class SidenavComponent implements OnInit {

  private mediaMatcher: MediaQueryList = matchMedia(`(max-width: ${WIDTH_OF_SMALL_SCREEN}px)`);
  employees: Observable<Employee[]>;

  constructor( private employeeService: EmployeeService) {

   }

  ngOnInit() {
    this.employees = this.employeeService.employees;
    this.employeeService.loadAll();
  }

  showFiller = false;

  isSmallScreen(): boolean {
    // 'True' will be retured if the screen is found to be less than 720px
    return this.mediaMatcher.matches;
  }

}
