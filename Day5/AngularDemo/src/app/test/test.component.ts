import { Component, OnInit } from '@angular/core';
import { Emp } from '../emp';
import { ArrayType } from '@angular/compiler';

@Component({
  selector: 'app-test',
  templateUrl: './test.component.html',
  styleUrls: ['./test.component.css']
})
export class TestComponent implements OnInit {
list:Emp[];
  constructor() {
    //read local storage
    this.list=JSON.parse(((localStorage.getItem('list'))))
    console.log(this.list)
   }

  ngOnInit(): void {
  }

}
