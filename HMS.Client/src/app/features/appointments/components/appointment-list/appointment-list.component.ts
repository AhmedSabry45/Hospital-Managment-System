import { Component } from '@angular/core';

@Component({
  selector: 'app-appointment-list',
  templateUrl: './appointment-list.component.html',
  styleUrl: './appointment-list.component.css'
})
export class AppointmentListComponent {
  patientServices = [
    { name: 'كشف', count: 25, color: '#1E90FF' },
    { name: 'استشارة', count: 15, color: '#FFA500' },
    { name: 'عمليات', count: 10, color: '#8B0000' },
    { name: 'أشعة', count: 8, color: '#FF6347' },
    { name: 'تحاليل', count: 12, color: '#20B2AA' },
    { name: 'طوارئ', count: 5, color: '#FF0000' },
  ];

  patients = [
    { id: 1, name: 'محمد أحمد', age: 30, service: 'كشف', clinic: 'عيادة الباطنة' },
    { id: 2, name: 'سلمى علي', age: 25, service: 'استشارة', clinic: 'عيادة العيون' },
    { id: 3, name: 'أحمد عبد الله', age: 40, service: 'عمليات', clinic: 'عيادة العظام' },
    { id: 4, name: 'ليلى محمود', age: 35, service: 'أشعة', clinic: 'أشعة ركبة' },
    { id: 5, name: 'خالد يوسف', age: 50, service: 'تحاليل', clinic: 'تحليل دم' },
  ];

  filters = { name: '', service: '' };

  filteredAppointments = [...this.patients];

  applyFilters(event: Event) {
    event.preventDefault();
    const { name, service } = this.filters;

    this.filteredAppointments = this.patients.filter((patient) => {
      const matchesName = name ? patient.name.includes(name) : true;
      const matchesService = service ? patient.service === service : true;

      return matchesName && matchesService;
    });
  }

  resetFilters() {
    this.filters = { name: '', service: '' };
    this.filteredAppointments = [...this.patients];
  }

  getServiceColor(service: string): string {
    const serviceObj = this.patientServices.find((s) => s.name === service);
    return serviceObj ? serviceObj.color : '#000';
  }

}
