import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { ServiceRequestService } from '../../services/service-request.service';
import { ServiceRequest } from '../../models/service-request';


@Component({
  selector: 'app-service-requests',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './service-requests.component.html'
})

export class ServiceRequestsComponent implements OnInit {
  requests: ServiceRequest[] = [];
  newRequest: ServiceRequest = { title: '', description: '' };

  constructor(private service: ServiceRequestService) {}

  ngOnInit(): void {
    this.loadRequests();
  }

  loadRequests() {
    this.service.getAll().subscribe(data => this.requests = data);
  }

  submit() {
    if (!this.newRequest.title?.trim() || !this.newRequest.description?.trim()) {
      alert('Title and description are required.');
      return;
    }

    this.service.create(this.newRequest).subscribe({
      next: () => {
        this.newRequest = { title: '', description: '' };
        this.loadRequests();
      },
      error: (err) => {
        console.error('POST failed', err);
        alert('Failed to submit service request.');
      }
    });
  }
}
