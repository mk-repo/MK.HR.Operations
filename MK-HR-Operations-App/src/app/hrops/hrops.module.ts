import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { HropsRoutingModule } from './hrops-routing.module';
import { MaterialModule } from '../shared/material.module';
import { FormsModule } from '@angular/forms';

import { HomeComponent } from './home/home.component';
import { EmployeeComponent } from './employee/employee.component';


@NgModule({
  declarations: [HomeComponent, EmployeeComponent],
  imports: [
    CommonModule,
    HropsRoutingModule,
    MaterialModule,
    FormsModule
  ]
})
export class HropsModule { }
