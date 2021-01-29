import { Component, OnInit } from '@angular/core';
import { FormArray, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { ContactClient, ContactModel } from 'src/app/api/SimplePhoneBookApi';

@Component({
  selector: 'app-create-contact',
  templateUrl: './create-contact.component.html',
  styleUrls: ['./create-contact.component.scss']
})
export class CreateContactComponent implements OnInit {

  profileForm: FormGroup = this.fb.group({
    firstName: ['', Validators.required],
    lastName: [''],
    emailAddress: [''],
    phoneNumber: ['']
  });

  constructor(
    private router: Router,
    private fb: FormBuilder,
    private contactClient: ContactClient) { }

  ngOnInit(): void {
  }

  onSubmit(): void {
    const newContact: ContactModel = this.profileForm.value;
    this.contactClient.createNewContact(newContact).subscribe(
      success => {
        this.router.navigate(['contact']);
      },
      error =>
      {
        this.router.navigate(['contact']);
      }
    );
  }

  onCancel(): void {
    this.router.navigate(['contact']);
  }
}
