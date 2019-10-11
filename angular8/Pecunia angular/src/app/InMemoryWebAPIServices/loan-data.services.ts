﻿import { Injectable } from '@angular/core';
import { InMemoryDbService } from 'angular-in-memory-web-api';
import { HomeLoan } from '../Models/homeLoans';
import { CarLoan } from '../Models/carLoans';
import { EduLoan } from '../Models/eduLoans';

@Injectable({
  providedIn: 'root'
})
export class LoanDataService implements InMemoryDbService {

  constructor()
  {
  }

  createDb() {

    let homeloans = [
      new HomeLoan(1, "514AE31F-650E-49D5-B2EE-6C40C9218389", "0CBBB2C7-F6D5-43F6-ADB6-B4256DBD9D22", 1200000, 10.65, 8878.89, 123, "12/12/2012", "APPLIED", "SERVICE", 10, 98576.33, 2345.55),
      new HomeLoan(2, "7189AE64-9E95-484A-8F66-49C9DDDE6258", "67DDCAFB-BE3B-4A01-A184-43987216C8A2", 1000000, 10.65, 7658.78, 134, "12/02/2013", "APPLIED", "SERVICE", 23, 78576.33, 5345.55),
      new HomeLoan(3, "18BE45CD-9968-4555-BCBD-8E9F5D1D62C9", "C7D203E8-5E19-478D-AAE3-55403C96D731", 1300000, 10.65, 2345.67, 145, "12/11/2015", "APPLIED", "SERVICE", 12, 58576.33, 2545.55)
    ];


    let carloans = [
      new CarLoan(1, "614AE31F-650E-49D5-B2EE-6C40C9218389", "1CBBB2C7-F6D5-43F6-ADB6-B4256DBD9D22", 1200000, 10.65, 8878.89, 123, "12/12/2012", "APPLIED", "SERVICE", 98576.33, 2345.55, "OTHERS"),
      new CarLoan(2, "4189AE64-9E95-484A-8F66-49C9DDDE6258", "77DDCAFB-BE3B-4A01-A184-43987216C8A2", 1000000, 10.65, 7658.78, 134, "12/02/2013", "APPLIED", "SERVICE", 78576.33, 5345.55, "OTHERS"),
      new CarLoan(3, "68BE45CD-9968-4555-BCBD-8E9F5D1D62C9", "D7D203E8-5E19-478D-AAE3-55403C96D731", 1300000, 10.65, 2345.67, 145, "12/11/2015", "APPLIED", "SERVICE", 58576.33, 2545.55, "OTHERS")
    ];


    let eduloans = [
      new EduLoan(1, "614AE31F-650E-49D5-B2EE-6C40C9218389", "1CBBB2C7-F6D5-43F6-ADB6-B4256DBD9D22", 1200000, 10.65, 8878.89, 123, "12/12/2012", "APPLIED", "UNDERGRADUATE", "abc institute", "ASDFSER", 1),
      new EduLoan(2, "4189AE64-9E95-484A-8F66-49C9DDDE6258", "77DDCAFB-BE3B-4A01-A184-43987216C8A2", 1000000, 10.65, 7658.78, 134, "12/02/2013", "APPLIED", "POSTGRADUATE", "ghi institute", "ASDFSERT", 1),
      new EduLoan(3, "68BE45CD-9968-4555-BCBD-8E9F5D1D62C9", "D7D203E8-5E19-478D-AAE3-55403C96D731", 1300000, 10.65, 2345.67, 145, "12/11/2015", "APPLIED", "UNDERGRADUATE", "def institute", "ASDFSDRE", 1)
    ];

    return { homeloans, carloans, eduloans };
  }
}
