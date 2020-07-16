import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-details',
  templateUrl: './details.component.html',
  styleUrls: ['./details.component.css']
})
export class DetailsComponent implements OnInit {
uname:string;
  constructor(private router:Router) {
    this.uname=localStorage.getItem("uname")
  }

  ngOnInit(): void {
  }
  LogOut()
  {
    localStorage.clear(); //clear local storage data
    this.router.navigate(['/login'])

  }

}
