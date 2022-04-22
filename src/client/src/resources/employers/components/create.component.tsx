import { AutocompleteInput, Create, CreateProps, RaRecord, ReferenceInput, required, SimpleForm, TextInput } from "react-admin";

export const EmployerCreate = (props: CreateProps<RaRecord>) => (
  <Create {...props}>
    <SimpleForm>
      <TextInput source="name" variant="outlined" validate={[required()]} />
      <TextInput source="address" variant="outlined" validate={[required()]} />
      <TextInput source="phone" variant="outlined" validate={[required()]} />
      <ReferenceInput label="Kind of Activity" source="kindOfActivityId" reference="kindofactivities">
        <AutocompleteInput optionText="title" variant="outlined" validate={[required()]} />
      </ReferenceInput>
    </SimpleForm>
  </Create>
);