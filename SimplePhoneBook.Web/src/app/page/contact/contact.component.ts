import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';
import { ContactModel, ContactClient } from 'src/app/api/SimplePhoneBookApi';

@Component({
  selector: 'app-contact',
  templateUrl: './contact.component.html',
  styleUrls: ['./contact.component.scss']
})
export class ContactComponent implements OnInit {

  searchForm: FormGroup = this.fb.group({
    search: [''],
  });

  contacts$: Observable<ContactModel[]> | undefined;
  showSnackBar = false;
  snackBarTitle = '';
  snackBarMessage = '';
  constructor(
    private fb: FormBuilder,
    private contactClient: ContactClient,
    private router: Router) { }

  ngOnInit(): void {
    this.contacts$ = this.contactClient.getAllContacts();
  }

  editContact(contact: ContactModel): void {
    this.router.navigate(['/contact/edit', contact.id]);
  }
  onDelete(contact: ContactModel): void {
    if (contact.id) {
      this.contactClient.deleteContact(contact.id).subscribe(success => {
        location.reload();
      },
        error => {
          this.snackBarMessage = 'Failed to delete contact';
          this.snackBarTitle = 'Failed';
          this.showSnackBar = true;
        });
    }
  }

  searchForContact(): void {
    this.contacts$ = this.contactClient.searchContacts(this.searchForm.get('search')?.value);
  }
  refreshContact(): void {
    this.contacts$ = this.contactClient.getAllContacts();
  }
}
