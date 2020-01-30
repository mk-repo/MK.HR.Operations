import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FlexLayoutModule } from '@angular/flex-layout';
import { FormsModule } from '@angular/forms';

import { HropsRoutingModule } from './hrops-routing.module';
import { MaterialModule } from '../shared/material.module';

import { HomeComponent } from './home/home.component';
import { EmployeeComponent } from './employee/employee.component';
import { ToolbarComponent } from './components/toolbar/toolbar.component';
import { MainContentComponent } from './components/main-content/main-content.component';
import { SidenavComponent } from './components/sidenav/sidenav.component';

import { EmployeeService } from './services/employee.service';
import { HttpClientModule } from '@angular/common/http';


@NgModule({
  declarations: [HomeComponent, EmployeeComponent, ToolbarComponent, MainContentComponent, SidenavComponent],
  imports: [
    CommonModule,
    HttpClientModule,
    MaterialModule,
    FlexLayoutModule,
    FormsModule,
    HropsRoutingModule
  ],
  providers: [
    EmployeeService
  ]
})
export class HropsModule { }
