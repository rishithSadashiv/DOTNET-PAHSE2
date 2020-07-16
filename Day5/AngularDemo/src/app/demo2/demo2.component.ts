import { Component, OnInit } from '@angular/core';
import { Student } from '../student';

@Component({
  selector: 'app-demo2',
  templateUrl: './demo2.component.html',
  styleUrls: ['./demo2.component.css']
})
export class Demo2Component implements OnInit {
item:Student;
  constructor() {
    this.item={sid:1,sname:'Rohan',age:10,dob:new Date(2010,10,10)};
   }

  ngOnInit(): void {
  }

}
