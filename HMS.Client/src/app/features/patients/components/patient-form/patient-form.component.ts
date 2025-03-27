import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-patient-form',
  templateUrl: './patient-form.component.html',
  styleUrls: ['./patient-form.component.css']
})
export class PatientFormComponent implements OnInit {
  patientForm: FormGroup;
  contacts = [{ Name: '', email: '', phone: '', mobile: '' }];

  constructor(private fb: FormBuilder) {
    this.patientForm = this.fb.group({
      patientId: [''],
      patientName: [''],
      dataType: [''],
      district: [''],
      region: [''],
      insuranceCompany: [''],
      insuranceCategory: [''],
      insuranceNumber: ['']
    });
  }
  ngOnInit(): void {

  }
  addContact() {
    if (this.contacts.length < 2) {
      this.contacts.push({ Name: '', email: '', phone: '', mobile: '' });
    }
  }

  cancel() {
    this.patientForm.reset();
    this.contacts = [{ Name: '', email: '', phone: '', mobile: '' }];
  }

  onSubmit() {
    console.log('Form Submitted:', this.patientForm.value, this.contacts);
  }
}
