import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ContactComponent } from './page/contact/contact.component';
import { CreateContactComponent } from './page/create-contact/create-contact.component';
import { ContactClient } from './api/SimplePhoneBookApi';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { EditContactComponent } from './page/edit-contact/edit-contact.component';

@NgModule({
  declarations: [
    AppComponent,
    ContactComponent,
    CreateContactComponent,
    EditContactComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [ContactClient],
  bootstrap: [AppComponent]
})
export class AppModule { }
