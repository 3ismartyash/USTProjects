import { Component } from '@angular/core';
import { Router } from '@angular/router';  // For navigation after login/signup
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { sendPasswordResetEmail } from '@angular/fire/auth';
import { RouterModule } from '@angular/router'; // Import RouterModule
import {
  Auth,
  createUserWithEmailAndPassword,
  signInWithEmailAndPassword,
  GoogleAuthProvider,
  signInWithPopup
} from '@angular/fire/auth';

@Component({
  selector: 'app-auth',
  standalone: true,
  imports: [CommonModule, ReactiveFormsModule, FormsModule, RouterModule], // RouterModule here
  templateUrl: './auth.component.html',
  styleUrls: ['./auth.component.css']
})
export class AuthComponent {
  constructor(private auth: Auth, private router: Router) {}

  // Google sign-in method
  async signInWithGoogle() {
    const provider = new GoogleAuthProvider();
    try {
      const credential = await signInWithPopup(this.auth, provider);
      // User is signed in! Navigate to the desired page.
      console.log("User signed in with Google:", credential.user);
      this.router.navigate(['/']); // Navigate to home or another protected route
    } catch (error) {
      console.error("Google sign-in error:", error);
      // Handle error appropriately (e.g., display an error message to the user)
    }
  }

  isLoginMode = true; // Initially, show the login form
  isLoading = false;
  email = '';
  password = '';

  // Switch between login and register modes
  onSwitchMode() {
    this.isLoginMode = !this.isLoginMode;
  }

  authForm!: FormGroup; // Declare the form group

  ngOnInit() { // Initialize the form in ngOnInit
    this.authForm = new FormGroup({
      'email': new FormControl(null, [Validators.required, Validators.email]),
      'password': new FormControl(null, [Validators.required, Validators.minLength(6)])
    });
  }

  // Submit form for login or registration
  async onSubmit() {
    if (!this.authForm.valid) { return; } // Check form validity

    this.isLoading = true;
    this.email = this.authForm.value.email;  // Get values from the form
    this.password = this.authForm.value.password;

    try {
      if (this.isLoginMode) {
        // Login logic
        await signInWithEmailAndPassword(this.auth, this.email, this.password);
        console.log("User logged in successfully!");
        this.router.navigate(['/']); // Navigate after login
      } else {
        // Registration logic
        await createUserWithEmailAndPassword(this.auth, this.email, this.password);
        console.log("User registered successfully!");
        this.router.navigate(['/']); // Navigate after registration
      }
    } catch (error: any) {
      console.error("Authentication error:", error);
      this.isLoading = false;

      let errorMessage = 'An unknown error occurred!';
      if (error.code === 'auth/email-already-in-use') {
        errorMessage = 'This email is already in use.';
      } else if (error.code === 'auth/user-not-found') {
        errorMessage = 'User not found.';
      } else if (error.code === 'auth/wrong-password') {
        errorMessage = 'Incorrect password.';
      } else if (error.code === 'auth/invalid-email') {
        errorMessage = 'Invalid email format.';
      }

      alert(errorMessage); // Display the error message to the user
    } finally {
      this.isLoading = false;
    }
  }

  // Reset password functionality
  async onResetPassword() {
    if (!this.email) {
      // Handle the case where the email is not provided.
      return;
    }

    try {
      await sendPasswordResetEmail(this.auth, this.email);
      alert('Password reset email sent!'); // Notify the user
    } catch (error: any) {
      console.error("Password reset error:", error);

      let errorMessage = 'An unknown error occurred!';
      if (error.code === 'auth/user-not-found') {
        errorMessage = 'No user found with that email.';
      }

      alert(errorMessage); // Display error message if any
    }
  }
}
