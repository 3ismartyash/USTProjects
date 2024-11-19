import { Injectable } from '@angular/core';
import { CanActivate, Router, UrlTree } from '@angular/router';
import { Observable, of } from 'rxjs';
import { map, catchError, switchMap } from 'rxjs/operators';
import { Auth } from '@angular/fire/auth';

@Injectable({
  providedIn: 'root'
})
export class AuthGuard implements CanActivate {
  constructor(private auth: Auth, private router: Router) {}

  canActivate(): Observable<boolean | UrlTree> {
    return of(this.auth.currentUser).pipe( // Correct: Use from to convert Promise to Observable
      switchMap(user => {
        if (user) {
          return of(true); // User is logged in
        } else {
          return of(this.router.createUrlTree(['/auth'])); // Redirect to login
        }
      }),
      catchError(error => {
        console.error("Error in AuthGuard:", error);
        return of(this.router.createUrlTree(['/auth'])); // Redirect to login on error
      })
    );
  }
}