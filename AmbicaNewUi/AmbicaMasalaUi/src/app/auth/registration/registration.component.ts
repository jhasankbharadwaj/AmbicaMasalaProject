import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { AbstractControl, FormBuilder,FormControl, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { RouterLink, RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-registration',
  standalone: true,
  imports: [ReactiveFormsModule,RouterLink,RouterOutlet],
  templateUrl: './registration.component.html',
  styleUrl: './registration.component.css'
})
export class RegistrationComponent {

  rigistrationForm:FormGroup;
  constructor(private fb:FormBuilder){
    this.rigistrationForm=this.fb.nonNullable.group({
      name:["",[Validators.required,Validators.minLength(3)]],
      email:["",[Validators.required, Validators.email]],
      gender:["",[Validators.required]],
      address:["",[Validators.required,Validators.maxLength(100)]],
      password:["",[Validators.required,Validators.minLength(6)]],
      conformPassword:["",[Validators.required]]

    },{validators:this.passwordMatchValidator});
  }

  passwordMatchValidator(control: AbstractControl): { [key: string]: boolean } | null {
    const password = control.get('password')?.value;
    const conformPassword = control.get('conformPassword')?.value;
    if (password && conformPassword && password !== conformPassword) {
      return { mismatch: true };
    }
    return null;
  }

  onSubmit():void{

    if (this.rigistrationForm.valid) {
      console.log('Form Submitted', this.rigistrationForm.value);
    } else {
      console.error('Form is invalid');
    }
  }
}



