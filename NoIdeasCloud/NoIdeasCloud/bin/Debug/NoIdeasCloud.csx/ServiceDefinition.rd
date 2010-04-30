<?xml version="1.0" encoding="utf-8"?>
<serviceModel xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" name="NoIdeasCloud" generation="1" functional="0" release="0" Id="08c46b8c-d9cd-47c4-8d94-c7105424acdd" dslVersion="1.2.0.0" xmlns="http://schemas.microsoft.com/dsltools/RDSM">
  <groups>
    <group name="NoIdeasCloudGroup" generation="1" functional="0" release="0">
      <componentports>
        <inPort name="NoIdeasWebRole:HttpIn" protocol="http">
          <inToChannel>
            <lBChannelMoniker name="/NoIdeasCloud/NoIdeasCloudGroup/LB:NoIdeasWebRole:HttpIn" />
          </inToChannel>
        </inPort>
      </componentports>
      <settings>
        <aCS name="NoIdeasWebRoleInstances" defaultValue="[1,1,1]">
          <maps>
            <mapMoniker name="/NoIdeasCloud/NoIdeasCloudGroup/MapNoIdeasWebRoleInstances" />
          </maps>
        </aCS>
        <aCS name="NoIdeasWebRole:DiagnosticsConnectionString" defaultValue="">
          <maps>
            <mapMoniker name="/NoIdeasCloud/NoIdeasCloudGroup/MapNoIdeasWebRole:DiagnosticsConnectionString" />
          </maps>
        </aCS>
      </settings>
      <channels>
        <lBChannel name="LB:NoIdeasWebRole:HttpIn">
          <toPorts>
            <inPortMoniker name="/NoIdeasCloud/NoIdeasCloudGroup/NoIdeasWebRole/HttpIn" />
          </toPorts>
        </lBChannel>
      </channels>
      <maps>
        <map name="MapNoIdeasWebRoleInstances" kind="Identity">
          <setting>
            <sCSPolicyIDMoniker name="/NoIdeasCloud/NoIdeasCloudGroup/NoIdeasWebRoleInstances" />
          </setting>
        </map>
        <map name="MapNoIdeasWebRole:DiagnosticsConnectionString" kind="Identity">
          <setting>
            <aCSMoniker name="/NoIdeasCloud/NoIdeasCloudGroup/NoIdeasWebRole/DiagnosticsConnectionString" />
          </setting>
        </map>
      </maps>
      <components>
        <groupHascomponents>
          <role name="NoIdeasWebRole" generation="1" functional="0" release="0" software="C:\Users\Adam\gitRepo\noIdeas\NoIdeasCloud\NoIdeasCloud\obj\Debug\NoIdeasWebRole\" entryPoint="base\x64\WaWebHost.exe" parameters="" memIndex="1792" hostingEnvironment="frontendfulltrust" hostingEnvironmentVersion="2">
            <componentports>
              <inPort name="HttpIn" protocol="http" />
            </componentports>
            <settings>
              <aCS name="DiagnosticsConnectionString" defaultValue="" />
              <aCS name="__ModelData" defaultValue="&lt;m role=&quot;NoIdeasWebRole&quot; xmlns=&quot;urn:azure:m:v1&quot;&gt;&lt;r name=&quot;NoIdeasWebRole&quot;&gt;&lt;e name=&quot;HttpIn&quot; /&gt;&lt;/r&gt;&lt;/m&gt;" />
            </settings>
            <resourcereferences>
              <resourceReference name="DiagnosticStore" defaultAmount="[4096,4096,4096]" defaultSticky="true" kind="Directory" />
              <resourceReference name="EventStore" defaultAmount="[1000,1000,1000]" defaultSticky="false" kind="LogStore" />
            </resourcereferences>
          </role>
          <sCSPolicy>
            <sCSPolicyIDMoniker name="/NoIdeasCloud/NoIdeasCloudGroup/NoIdeasWebRoleInstances" />
          </sCSPolicy>
        </groupHascomponents>
      </components>
      <sCSPolicy>
        <sCSPolicyID name="NoIdeasWebRoleInstances" defaultPolicy="[1,1,1]" />
      </sCSPolicy>
    </group>
  </groups>
  <implements>
    <implementation Id="17151852-f575-41bc-ac0b-ffe18cfc0774" ref="Microsoft.RedDog.Contract\ServiceContract\NoIdeasCloudContract@ServiceDefinition">
      <interfacereferences>
        <interfaceReference Id="b5dab1bb-bf62-45ca-a687-a242d5c2157f" ref="Microsoft.RedDog.Contract\Interface\NoIdeasWebRole:HttpIn@ServiceDefinition">
          <inPort>
            <inPortMoniker name="/NoIdeasCloud/NoIdeasCloudGroup/NoIdeasWebRole:HttpIn" />
          </inPort>
        </interfaceReference>
      </interfacereferences>
    </implementation>
  </implements>
</serviceModel>