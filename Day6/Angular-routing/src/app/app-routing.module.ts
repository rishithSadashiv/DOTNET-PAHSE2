import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { AboutComponent } from './about/about.component';
import { ContactComponent } from './contact/contact.component';
import { LoginComponent } from './login/login.component';
import { DetailsComponent } from './details/details.component';


const routes: Routes = [
  {path:'home',component:HomeComponent,children:[
    
  ]},
  {path:'about',component:AboutComponent},
  {path:'info',component:ContactComponent},
  {path:'login',component:LoginComponent},
  {path:'details/:un',component:DetailsComponent},
  {path:'',redirectTo:'home',pathMatch:"full"}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
