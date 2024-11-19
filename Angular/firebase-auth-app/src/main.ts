import { bootstrapApplication } from '@angular/platform-browser';
import { AppComponent } from './app/app.component';
import { provideFirebaseApp, initializeApp } from '@angular/fire/app';
import { getAuth, provideAuth } from '@angular/fire/auth';
import { environment } from './environments/environment';
import { appConfig } from './app/app.config'; 

bootstrapApplication(AppComponent, {
  ...appConfig, 
  providers: [
    provideFirebaseApp(() => initializeApp(environment.firebase)),
    provideAuth(() => getAuth()),
    ...(appConfig.providers) // This now includes your existing providers
  ]
}).catch(err => console.error(err));