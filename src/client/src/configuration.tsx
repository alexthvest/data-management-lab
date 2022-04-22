import restProvider from "ra-data-simple-rest";

import { AdminConfiguration } from "./common/models";

import { applicantResource } from "./resources/applicants";
import { employerResource } from "./resources/employers";
import { kindOfActivityResource } from "./resources/kind-of-activities";
import { appointmentResource } from "./resources/appointments";


export const configuration: AdminConfiguration = {
  dataProvider: restProvider("api"),
  resources: [
    employerResource,
    applicantResource,
    kindOfActivityResource,
    appointmentResource,
  ]
};