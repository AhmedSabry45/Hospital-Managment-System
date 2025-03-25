import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-patient-form',
  templateUrl: './patient-form.component.html',
  styleUrls: ['./patient-form.component.css']
})
export class PatientFormComponent implements OnInit {
  patientForm: FormGroup;

  constructor(private fb: FormBuilder) {
    this.patientForm = this.fb.group({
      dataType: ['', Validators.required],
      district: [''],
      region: [''],
      ward1: [''],
      ward2: [''],
      street: [''],
      patientId: [''],
      hasComments: [false],
      comment1: [''],
      comment2: ['']
    });
  }

  ngOnInit(): void { }

  onSubmit(): void {
    if (this.patientForm.valid) {
      console.log('Form Submitted', this.patientForm.value);
      // Handle form submission (e.g., send data to a server)
    } else {
      console.log('Form is invalid');
    }
  }
}
