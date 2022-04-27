import { useState } from "react";
import { AutocompleteInput, ReferenceInput, SimpleForm, TextInput, required } from "react-admin";

export const EmployerForm = () => {
  const [koaEditable, setKoaEditable] = useState(true);
  
  return (
    <SimpleForm>
      <TextInput source="name" variant="outlined" validate={[required()]} />
      <TextInput source="address" variant="outlined" validate={[required()]} />
      <TextInput source="phone" variant="outlined" validate={[required()]} />

      <input type="checkbox" checked={koaEditable} onChange={e => setKoaEditable(e.target.checked)} />

      {koaEditable && 
        <ReferenceInput label="Kind of Activity" source="kindOfActivityId" reference="kindofactivities" >
          <AutocompleteInput optionText="title" variant="outlined" defaultValue={0} validate={[required()]} />
        </ReferenceInput>
      }

      {!koaEditable &&
        <TextInput source="kindOfActivity" variant="outlined" validate={[required()]} />
      }

    </SimpleForm>
  );
};