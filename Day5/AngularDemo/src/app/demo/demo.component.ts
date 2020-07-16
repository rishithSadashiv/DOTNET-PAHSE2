import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-demo',
  templateUrl: './demo.component.html',
  styleUrls: ['./demo.component.css']
})
export class DemoComponent implements OnInit {
name:string="Rohan"
  greet:string="Hello Angular..";
age:number=10;
a=10;
msg:any="Hello"
no:number[]=[12,23,34,5] //array
flag:boolean=true;
  constructor() { }

  ngOnInit(): void {
  }

}
