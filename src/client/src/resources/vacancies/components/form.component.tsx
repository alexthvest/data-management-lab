import { required, SimpleForm, NumberInput, BooleanInput, ReferenceInput, AutocompleteInput } from "react-admin";
import { RichTextInput } from "ra-input-rich-text";

export const VacancyForm = () => (
  <SimpleForm>
      <ReferenceInput label="Employer" source="employerId" reference="employers" >
        <AutocompleteInput optionText="name" variant="outlined" validate={[required()]} />
      </ReferenceInput>
      <ReferenceInput label="Appointment" source="appointmentId" reference="appointments" >
        <AutocompleteInput optionText="title" variant="outlined" validate={[required()]} />
      </ReferenceInput>
      <NumberInput source="salary" />
      <BooleanInput source="isOpen" />
      <RichTextInput source="description" />
  </SimpleForm>
);
