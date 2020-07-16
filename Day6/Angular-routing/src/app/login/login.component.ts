import { Component, OnInit } from '@angular/core';
import { Router } from "@angular/router";
import { User } from '../user';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
item:User;
uname:string;
pwd:string;
  constructor(private router:Router) {
    this.item=new User();
  }

  ngOnInit(): void {
  }
  Validate()
  {
    this.item={uname:this.uname,pwd:this.pwd};
    if(this.item.uname=="Rahul" && this.item.pwd=="12345")
    {
        localStorage.setItem("uname",this.item.uname)
        this.router.navigateByUrl('details') //details is route name

    }
  }

}
