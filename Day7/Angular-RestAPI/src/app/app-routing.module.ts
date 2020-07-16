import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ProductViewComponent } from './product-view/product-view.component';


const routes: Routes = [
  {path:'view',component:ProductViewComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
