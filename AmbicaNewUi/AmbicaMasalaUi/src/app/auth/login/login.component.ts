import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormBuilder, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { RouterLink } from '@angular/router';
import { RegistrationComponent } from '../registration/registration.component';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [RouterLink, CommonModule, ReactiveFormsModule,RegistrationComponent],
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
  loginForm: FormGroup;

  constructor(private fb: FormBuilder) {
    this.loginForm = this.fb.group({
      email: ['', [Validators.required, Validators.email]],
      password: ['', [Validators.required, Validators.minLength(6)]]
    });
  }

  onSubmit() {
    if (this.loginForm.valid) {
      console.log('Form Submitted', this.loginForm.value);
    } else {
      console.log('Form is invalid');
    }
  }

  async onGoogleSignIn() {
    try {
      const googleAuth = (window as any).google.accounts.id;
      googleAuth.initialize({
        client_id: 'YOUR_GOOGLE_CLIENT_ID', // Replace with your actual client ID
        callback: (response: any) => this.handleGoogleResponse(response)
      });
      googleAuth.prompt();
    } catch (error) {
      console.error('Google Sign-In initialization failed:', error);
    }
  }

  handleGoogleResponse(response: any) {
    console.log('Google Sign-In response:', response);
    // You can further process the response, such as sending the token to your backend
  }
}
