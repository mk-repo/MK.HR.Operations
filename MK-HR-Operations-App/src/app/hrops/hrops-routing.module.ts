import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { EmployeeComponent } from './employee/employee.component';
import { MainContentComponent } from './components/main-content/main-content.component';


const routes: Routes = [
  { path: '', component: HomeComponent,
    children: [
      { path: '', component: MainContentComponent },
      { path: 'employee', component: EmployeeComponent },
      { path: 'employee', component: EmployeeComponent },
      { path: 'employee', component: EmployeeComponent }
    ]
  },
  { path: '**', redirectTo: '' }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class HropsRoutingModule { }
