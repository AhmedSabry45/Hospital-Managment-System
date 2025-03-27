import { Component } from '@angular/core';

@Component({
  selector: 'app-patient-list',
  templateUrl: './patient-list.component.html',
  styleUrl: './patient-list.component.css'
})
export class PatientListComponent {
  patientStatuses = [
    { name: 'إقامة', count: 20, color: '#1E90FF' },
    { name: 'متابعة', count: 15, color: '#FFA500' },
    { name: 'عمليات', count: 10, color: '#8B0000' },
    { name: 'حالة حرجة', count: 5, color: '#FF0000' },
    { name: 'تم علاجه', count: 30, color: '#008000' },
    { name: 'أرشيف', count: 25, color: '#808080' },
  ];

  patients = [
    { id: 1, name: 'محمد أحمد', age: 30, status: 'إقامة' },
    { id: 2, name: 'سلمى علي', age: 25, status: 'متابعة' },
    { id: 3, name: 'أحمد عبد الله', age: 40, status: 'حالة حرجة' },
    { id: 4, name: 'ليلى محمود', age: 35, status: 'عمليات' },
    { id: 5, name: 'خالد يوسف', age: 50, status: 'تم علاجه' },
  ];

  filters = { name: '', status: '' };

  filteredPatients = [...this.patients];

  applyFilters(event: Event) {
    event.preventDefault();
    const { name, status } = this.filters;

    this.filteredPatients = this.patients.filter((patient) => {
      const matchesName = name ? patient.name.includes(name) : true;
      const matchesStatus = status ? patient.status === status : true;

      return matchesName && matchesStatus;
    });
  }
  resetFilters() {
    this.filters = { name: '', status: '' };
    this.filteredPatients = [...this.patients];
  }

  getStatusColor(status: string): string {
    const statusObj = this.patientStatuses.find((s) => s.name === status);
    return statusObj ? statusObj.color : '#000';
  }
}
