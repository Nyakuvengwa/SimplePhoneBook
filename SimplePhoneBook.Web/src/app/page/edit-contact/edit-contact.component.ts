import { Component, OnInit } from '@angular/core';
import { FormGroup, Validators, FormBuilder } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { ContactClient, ContactModel } from 'src/app/api/SimplePhoneBookApi';

@Component({
  selector: 'app-edit-contact',
  templateUrl: './edit-contact.component.html',
  styleUrls: ['./edit-contact.component.scss']
})
export class EditContactComponent implements OnInit {
  profileForm: FormGroup = this.fb.group({
    id: [''],
    firstName: ['', Validators.required],
    lastName: [''],
    emailAddress: [''],
    phoneNumber: ['']
  });
  constructor(
    private router: Router,
    private fb: FormBuilder,
    private route: ActivatedRoute,
    private contactClient: ContactClient) { }

  ngOnInit(): void {
    const contactId = this.route.snapshot.paramMap.get('id');
    console.log('lets see if this is hit');
    if (contactId) {
      // tslint:disable-next-line: radix
      this.contactClient.getContact(parseInt(contactId)).subscribe(
        success => {
        this.profileForm.patchValue(success);
      },
      error => {
        this.router.navigate(['contact']);
      });
    }

  }

  onSubmit(): void {
    const savedContact: ContactModel = this.profileForm.value;
    this.contactClient.updateContact(savedContact).subscribe(
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
