﻿<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="4.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">x86</Platform>
    <ProductVersion>8.0.30703</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{D974663F-41C7-4AFF-9D23-13C3228E467F}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>Finger_ATM</RootNamespace>
    <AssemblyName>Finger_ATM</AssemblyName>
    <TargetFrameworkVersion>v3.5</TargetFrameworkVersion>
    <FileAlignment>512</FileAlignment>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|x86' ">
    <PlatformTarget>x86</PlatformTarget>
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>DEBUG;TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|x86' ">
    <PlatformTarget>x86</PlatformTarget>
    <DebugType>pdbonly</DebugType>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <PropertyGroup Condition="'$(Configuration)|$(Platform)' == 'Debug|x64'">
    <DebugSymbols>true</DebugSymbols>
    <OutputPath>bin\x64\Debug\</OutputPath>
    <DefineConstants>DEBUG;TRACE</DefineConstants>
    <DebugType>full</DebugType>
    <PlatformTarget>x64</PlatformTarget>
    <ErrorReport>prompt</ErrorReport>
    <CodeAnalysisRuleSet>MinimumRecommendedRules.ruleset</CodeAnalysisRuleSet>
  </PropertyGroup>
  <PropertyGroup Condition="'$(Configuration)|$(Platform)' == 'Release|x64'">
    <OutputPath>bin\x64\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <Optimize>true</Optimize>
    <DebugType>pdbonly</DebugType>
    <PlatformTarget>x64</PlatformTarget>
    <ErrorReport>prompt</ErrorReport>
    <CodeAnalysisRuleSet>MinimumRecommendedRules.ruleset</CodeAnalysisRuleSet>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="Check">
      <HintPath>..\..\Apply\Check.dll</HintPath>
    </Reference>
    <Reference Include="SecuGen.FDxSDKPro.Windows">
      <HintPath>..\..\Matching\bin\Debug\SecuGen.FDxSDKPro.Windows.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Core" />
    <Reference Include="System.Xml.Linq" />
    <Reference Include="System.Data.DataSetExtensions" />
    <Reference Include="System.Data" />
    <Reference Include="System.Deployment" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Windows.Forms" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="AddCandidate.cs">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="AddCandidate.Designer.cs">
      <DependentUpon>AddCandidate.cs</DependentUpon>
    </Compile>
    <Compile Include="AddElection.cs">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="AddElection.Designer.cs">
      <DependentUpon>AddElection.cs</DependentUpon>
    </Compile>
    <Compile Include="AddVoter.cs">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="AddVoter.Designer.cs">
      <DependentUpon>AddVoter.cs</DependentUpon>
    </Compile>
    <Compile Include="AdminLogin.cs">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="AdminLogin.Designer.cs">
      <DependentUpon>AdminLogin.cs</DependentUpon>
    </Compile>
    <Compile Include="AdminMenu.cs">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="AdminMenu.Designer.cs">
      <DependentUpon>AdminMenu.cs</DependentUpon>
    </Compile>
    <Compile Include="Program.cs" />
    <Compile Include="Properties\AssemblyInfo.cs" />
    <Compile Include="Result.cs">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="Result.Designer.cs">
      <DependentUpon>Result.cs</DependentUpon>
    </Compile>
    <Compile Include="TakeElection.cs">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="TakeElection.Designer.cs">
      <DependentUpon>TakeElection.cs</DependentUpon>
    </Compile>
    <Compile Include="ViewCandidate.cs">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="ViewCandidate.Designer.cs">
      <DependentUpon>ViewCandidate.cs</DependentUpon>
    </Compile>
    <Compile Include="ViewResult.cs">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="ViewResult.Designer.cs">
      <DependentUpon>ViewResult.cs</DependentUpon>
    </Compile>
    <EmbeddedResource Include="AddCandidate.resx">
      <DependentUpon>AddCandidate.cs</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="AddElection.resx">
      <DependentUpon>AddElection.cs</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="AddVoter.resx">
      <DependentUpon>AddVoter.cs</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="AdminLogin.resx">
      <DependentUpon>AdminLogin.cs</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="AdminMenu.resx">
      <DependentUpon>AdminMenu.cs</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="Properties\Resources.resx">
      <Generator>ResXFileCodeGenerator</Generator>
      <LastGenOutput>Resources.Designer.cs</LastGenOutput>
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <Compile Include="Properties\Resources.Designer.cs">
      <AutoGen>True</AutoGen>
      <DependentUpon>Resources.resx</DependentUpon>
      <DesignTime>True</DesignTime>
    </Compile>
    <EmbeddedResource Include="Result.resx">
      <DependentUpon>Result.cs</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="TakeElection.resx">
      <DependentUpon>TakeElection.cs</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="ViewCandidate.resx">
      <DependentUpon>ViewCandidate.cs</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="ViewResult.resx">
      <DependentUpon>ViewResult.cs</DependentUpon>
    </EmbeddedResource>
    <None Include="Properties\Settings.settings">
      <Generator>SettingsSingleFileGenerator</Generator>
      <LastGenOutput>Settings.Designer.cs</LastGenOutput>
    </None>
    <Compile Include="Properties\Settings.Designer.cs">
      <AutoGen>True</AutoGen>
      <DependentUpon>Settings.settings</DependentUpon>
      <DesignTimeSharedInput>True</DesignTimeSharedInput>
    </Compile>
  </ItemGroup>
  <ItemGroup>
    <None Include="Resources\Avoid-ATM-Credit-Card-Fees.jpg" />
  </ItemGroup>
  <ItemGroup>
    <Folder Include="Finger\" />
  </ItemGroup>
  <ItemGroup>
    <None Include="Resources\Capture.JPG" />
  </ItemGroup>
  <ItemGroup>
    <None Include="Resources\Fingerprint-large-Small.jpg" />
  </ItemGroup>
  <ItemGroup>
    <None Include="Resources\Line.png" />
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.CSharp.targets" />
  <!-- To modify your build process, add your task inside one of the targets below and uncomment it. 
       Other similar extension points exist, see Microsoft.Common.targets.
  <Target Name="BeforeBuild">
  </Target>
  <Target Name="AfterBuild">
  </Target>
  -->
</Project>