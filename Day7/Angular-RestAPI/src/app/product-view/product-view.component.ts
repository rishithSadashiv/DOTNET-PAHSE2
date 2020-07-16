import { Component, OnInit } from '@angular/core';
import { Product } from '../Models/product';
import { ProductService } from '../Shared/product.service';


@Component({
  selector: 'app-product-view',
  templateUrl: './product-view.component.html',
  styleUrls: ['./product-view.component.css']
})
export class ProductViewComponent implements OnInit {
list:Product[];
pid:number;
pname:string;
price:number;
stock:number;
obj:Product;
errmsg:string;
  constructor(private service:ProductService) {
    this.service.GetAll().subscribe(i=>{
      this.list=i
      console.log(this.list)
    })
  }

  ngOnInit(): void {
  }
  Search()
  {
    this.service.Get(this.pid).subscribe(item=>{
      this.obj=item;
      console.log(this.obj);
      if(this.obj!=null)
      {
      this.pname=this.obj.pname;
      this.stock=this.obj.stock;
      this.price=this.obj.price;
      this.errmsg="";
      }
      else
      {
        this.errmsg="Invalid Id";
      }
    })

  }
  public Add()
  {
   this.obj=new Product();
   this.obj.pname=this.pname;
   this.obj.price=this.price;
   this.obj.stock=this.stock;
  this.service.Add(this.obj).subscribe()
  }
  public Update()
  {
    this.obj={pid:Number(this.pid),
      pname:this.pname,
      price:this.price,
    stock:this.stock};
    this.service.Update(this.obj).subscribe(i=>{
      console.log(i)
    })
  }
  public Delete()
  {
    this.service.Delete(this.pid).subscribe(res=>{
      console.log(res);
    })
  }

}
