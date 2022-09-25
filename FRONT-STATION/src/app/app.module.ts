import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LodingComponent } from './components/loding/loding.component';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { TopNavbarComponent } from './components/top-navbar/top-navbar.component';
import { SideNavbarComponent } from './components/side-navbar/side-navbar.component';
import { CardUserComponent } from './components/card-user/card-user.component';
import { CardFriendComponent } from './components/card-friend/card-friend.component';
import { UserImageComponent } from './components/user-image/user-image.component';
import { LoadingAnimationComponent } from './components/loading-animation/loading-animation.component';
import { HttpClientModule } from '@angular/common/http';
import { LoginComponent } from './components/login/login.component';

@NgModule({
  declarations: [
    AppComponent,
    LodingComponent,
    DashboardComponent,
    TopNavbarComponent,
    SideNavbarComponent,
    CardUserComponent,
    CardFriendComponent,
    UserImageComponent,
    LoadingAnimationComponent,
    LoginComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
