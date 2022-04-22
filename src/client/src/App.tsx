import React from "react";
import { Admin, Resource } from "react-admin";

import { AdminConfiguration } from "./common/models";

export const App: React.FC<AdminConfiguration> = ({ dataProvider, resources }) => {
  return (
    <Admin dataProvider={dataProvider}>
      {resources.map(({ icon, name, options, components: { list, edit, create } }) => 
        <Resource 
          icon={icon} name={name} options={options}
          list={list} create={create} edit={edit} />  
      )}
    </Admin>
  );
};
