import { SvgIconComponent } from "@mui/icons-material";
import { ComponentType, ReactElement } from "react";
import { DataProvider, ResourceOptions } from "react-admin";

export interface AdminConfiguration {
  readonly dataProvider: DataProvider;
  readonly resources: ResourceItem[];
}

export interface ResourceItem {
  readonly name: string;
  readonly icon: SvgIconComponent;
  readonly options?: ResourceOptions;

  readonly components: {
    list:  ComponentType<any> | ReactElement;
    create?:  ComponentType<any> | ReactElement;
    edit?:  ComponentType<any> | ReactElement;
  };
}