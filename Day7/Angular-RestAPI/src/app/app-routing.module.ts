import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ProductViewComponent } from './product-view/product-view.component';
import { NotFoundComponent } from './not-found/not-found.component';


const routes: Routes = [
  {path:'view',component:ProductViewComponent},
  {path:'notfound',component:NotFoundComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
