import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { TestComponent } from './test/test.component';
import { EmpViewComponent } from './emp-view/emp-view.component';


const routes: Routes = [
  {path:'test',component:TestComponent},
  {path:'emp',component:EmpViewComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
