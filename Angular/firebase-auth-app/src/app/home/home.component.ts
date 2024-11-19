import { Component, OnInit, OnDestroy } from '@angular/core';
import { Auth, signOut } from '@angular/fire/auth';
import { Router } from '@angular/router';
import { Subscription, from, of } from 'rxjs';
import { switchMap } from 'rxjs/operators';
import { CommonModule } from '@angular/common';


@Component({
  selector: 'app-home',
  standalone: true,
  imports: [CommonModule], // Make sure CommonModule is imported
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit, OnDestroy {
  private userSub!: Subscription;
  userEmail: string | null = null;
  

  constructor(private auth: Auth, private router: Router) {}

  ngOnInit() {
    this.userSub = of(this.auth.currentUser).pipe(
      switchMap(user => {
        if (user) {
          this.userEmail = user.email;
          return of(user);
        } else {
          this.userEmail = null;
          return of(null); // Return observable of null
        }
      })
    ).subscribe();
  }


  ngOnDestroy() {
    if (this.userSub) {
      this.userSub.unsubscribe();
    }
  }

  onLogout() {
    signOut(this.auth).then(() => {
      this.router.navigate(['/auth']);
    }).catch(error => {
      console.error("Logout error:", error); // Handle logout errors
    });
  }
}