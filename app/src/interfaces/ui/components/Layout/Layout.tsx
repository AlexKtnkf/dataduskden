import React, { Children, PropsWithChildren } from 'react';
import { Layout as AntLayout, Space } from 'antd';

const { Header, Footer, Sider, Content } = AntLayout;

const headerStyle: React.CSSProperties = {
  textAlign: 'center',
  color: '#fff',
  height: 64,
  paddingInline: 50,
  lineHeight: '64px',
  backgroundColor: '#7dbcea',
};

const contentStyle: React.CSSProperties = {
  textAlign: 'center',
  minHeight: 120,
  lineHeight: '120px',
  color: '#fff',
  backgroundColor: '#108ee9',
};

const siderStyle: React.CSSProperties = {
  textAlign: 'center',
  lineHeight: '120px',
  color: '#fff',
  backgroundColor: '#3ba0e9',
};

const footerStyle: React.CSSProperties = {
  textAlign: 'center',
  color: '#fff',
  backgroundColor: '#7dbcea',
};

const Layout: React.FC = (props: PropsWithChildren<any>) => (
  <Space direction="vertical" style={{ width: '100%' }} size={[0, 48]}>
    <AntLayout>
      <Sider style={siderStyle}>Sider</Sider>
      <AntLayout>
        <Header style={headerStyle}>Header</Header>
        <Content style={contentStyle}>{props.children}</Content>
        <Footer style={footerStyle}>Footer</Footer>
      </AntLayout>
    </AntLayout>
  </Space>
);

export default Layout;
