import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ContactComponent } from './page/contact/contact.component';
import { CreateContactComponent } from './page/create-contact/create-contact.component';
import { EditContactComponent } from './page/edit-contact/edit-contact.component';

const routes: Routes = [
  { path: 'contact', component: ContactComponent },
  { path: 'contact/create', component: CreateContactComponent },
  { path: 'contact/edit/:id', component:  EditContactComponent},
  { path: '', pathMatch: 'full', redirectTo: 'contact' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
