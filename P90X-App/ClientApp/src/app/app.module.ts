import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { AppRoutingModule } from './app-routing.module';
import { WorkoutComponent } from './workout/workout.component';
import { WorkoutDetailComponent } from './workout/workout-detail/workout-detail.component';
import { WorkoutEditComponent } from './workout/workout-edit/workout-edit.component';
import { WorkoutItemComponent } from './workout/workout-list/workout-item/workout-item.component';
import { WorkoutListComponent } from './workout/workout-list/workout-list.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    WorkoutDetailComponent,
    WorkoutEditComponent,
    WorkoutItemComponent,
    WorkoutListComponent,
    WorkoutComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
