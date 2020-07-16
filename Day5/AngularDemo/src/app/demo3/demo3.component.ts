import { Component, OnInit } from '@angular/core';
import { Student } from '../student';

@Component({
  selector: 'app-demo3',
  templateUrl: './demo3.component.html',
  styleUrls: ['./demo3.component.css']
})
export class Demo3Component implements OnInit {
list:Student[] //array
  constructor() {
    this.list=[
      {sid:1,sname:'Rohan',age:10,dob:new Date(2010,10,10)},
      {sid:2,sname:'Karan',age:10,dob:new Date(2010,10,10)},
      {sid:3,sname:'Suren',age:10,dob:new Date(2010,10,10)},
    ]
   }

  ngOnInit(): void {
  }

}
