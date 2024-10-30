import { CommonModule } from '@angular/common';
import { Component, inject } from '@angular/core';
import { ProductDisplayService } from '../services/product-display.service';

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent {
  productDisplayService=inject(ProductDisplayService)
  productsList:any[]=[];
public: any;

  ngOnInit():void {
    this.getProducts();
  }
  getProducts(){
    this.productDisplayService.getProducts().subscribe((res:any)=>{
      this.productsList=res;
    })
  }
}


