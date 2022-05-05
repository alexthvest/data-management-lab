import { required, SimpleForm, NumberInput, ReferenceInput, AutocompleteInput } from "react-admin";

export const DealForm = () => (
  <SimpleForm>
      <ReferenceInput label="Vacancy" source="vacancyId" reference="vacancies" >
        <AutocompleteInput optionText="id" variant="outlined" validate={[required()]} />
      </ReferenceInput>
      <ReferenceInput label="Applicant" source="applicantId" reference="applicants" >
        <AutocompleteInput optionText={(r => `${r.lastName} ${r.firstName} ${r.surname ?? ''}`)} variant="outlined" validate={[required()]} />
      </ReferenceInput>
      <NumberInput source="salary" />
      <NumberInput source="commission" />
  </SimpleForm>
);
