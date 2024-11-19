import { Component, OnInit, OnDestroy } from '@angular/core';
import { Auth, onAuthStateChanged } from '@angular/fire/auth';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule, RouterModule],
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit, OnDestroy {
  title = 'my-firebase-auth-app';
  isLoggedIn = false; // Initialize isLoggedIn
  private unsubscribe!: () => void; // Store unsubscribe function

  constructor(private auth: Auth) {}

  ngOnInit() {
    // Use onAuthStateChanged to subscribe to auth state changes
    this.unsubscribe = onAuthStateChanged(this.auth, (user) => {
      this.isLoggedIn = !!user; // Update isLoggedIn based on user state
    });
  }

  ngOnDestroy() {
    // Call the unsubscribe function when the component is destroyed
    if (this.unsubscribe) {
      this.unsubscribe();
    }
  }
}
