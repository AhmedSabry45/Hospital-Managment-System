import { Component, EventEmitter, Output } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-sidebar',
  templateUrl: './sidebar.component.html',
  styleUrl: './sidebar.component.css'
})
export class SidebarComponent {
  isCollapsed: boolean = false;
  activeMenu: string | null = null;
  activeSubmenuRoute: string = '';

  @Output() sidebarToggled = new EventEmitter<boolean>();

  constructor(private router: Router) { }

  toggleSubMenu(menu: string) {
    this.activeMenu = this.activeMenu === menu ? null : menu;
  }

  toggleSidebar() {
    this.isCollapsed = !this.isCollapsed;
    this.sidebarToggled.emit(this.isCollapsed);
  }

  logout() {
    console.log('Logging out...');
    this.router.navigate(['/login']);
  }
}
