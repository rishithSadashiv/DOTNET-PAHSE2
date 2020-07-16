import { Component, OnInit } from '@angular/core';
import { Emp } from '../emp';
import { JsonPipe } from '@angular/common';

@Component({
  selector: 'app-emp-view',
  templateUrl: './emp-view.component.html',
  styleUrls: ['./emp-view.component.css']
})
export class EmpViewComponent implements OnInit {
obj:Emp;
eid:number;
ename:string;
jd:Date;
sal:number;
desig:string;
list:string[]=["Programer","Sr Programmer"]
emplist:Emp[]=[];
  constructor() {
    this.obj=new Emp();
    if(localStorage.getItem("list"))
    {
      this.emplist=JSON.parse(localStorage.getItem("list"));
    }
   }

  ngOnInit(): void {
  }
  Add()
  {
    // this.obj.eid=this.eid;
    // this.obj.ename=this.ename;
    // this.obj.joindate=this.jd;
    // this.obj.salary=this.sal;
    // this.obj.desig=this.desig;
    this.obj={
      eid:this.eid,
      ename:this.ename,
      salary:this.sal,
      joindate:this.jd,
      desig:this.desig
    }
    this.emplist.push(this.obj)
    //set list data in local-storage
    localStorage.setItem("list",JSON.stringify(this.emplist))
    //add model to db tables using rest apis

  }

}
