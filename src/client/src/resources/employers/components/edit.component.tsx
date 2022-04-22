import { AutocompleteInput, Edit, EditProps, RaRecord, ReferenceInput, SimpleForm, TextInput, required } from "react-admin";

export const EmployerEdit = (props: EditProps<RaRecord>) => (
  <Edit {...props}>
    <SimpleForm>
      <TextInput source="name" validate={required()} />
      <TextInput source="address" validate={required()} />
      <TextInput source="phone" validate={required()} />
      <ReferenceInput label="Kind of Activity" source="kindOfActivityId" reference="kindofactivities" validate={required()}>
        <AutocompleteInput optionText="title" />
      </ReferenceInput>
    </SimpleForm>
  </Edit>
);