   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	   Y UCoreApplication.Infrastructure, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullwTclr-namespace:CoreApplication.Infrastructure;assembly=CoreApplication.InfrastructureCoreApplication.Infrastructure 5   	   P LCoreApplication.Shell, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:CoreApplication.ShellCoreApplication.Shell 5   	   W0clr-namespace:CoreApplication.Shell.UserControls"CoreApplication.Shell.UserControls 5   	   2   ,CoreApplication.Shell.Views.ProfesionalShell   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   n jMicrosoft.Practices.Prism.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35` \Microsoft.Practices.Prism, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35+prismhttp://www.codeplex.com/prism   5   	   5system&clr-namespace:System;assembly=mscorlib   5   	   `infTclr-namespace:CoreApplication.Infrastructure;assembly=CoreApplication.Infrastructure   5   	   /src#clr-namespace:CoreApplication.Shell   5   	   ;uc0clr-namespace:CoreApplication.Shell.UserControls   5   	   -   5        &   CoreApplication.Shell.WindowBase   Name$
  Root��5   	   $	��720��5	   	   $
��1280��6    � Title$ ProfesionalShell��5
   	   .��5      �  � UseLayoutRounding .    ShellDefaultBackground#���   5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $	��118 �6   �� 5      $��* �6   .+�5   
   /  )CoreApplication.Shell.UserControls.Header  -   5          Name$ Header��5      $��0��5         MainMenu 5      �� *MainMenuItems+   	StatsMenu 5      �� *StatsMenuItems+   
ConfigMenu 5      �� *ConfigMenuItems+   HelpMenu 5      �� *HelpMenuItems+�� 5   
   $��1��6   $��5q�5      $
��Auto=�5      $
��Auto=�5      .��5       �� -   5        	 ��Name$	 
HeadRegion��5       0  *CoreApplication.Infrastructure.RegionNames!
   ProfesionalShellHeadRegion5  /Microsoft.Practices.Prism.Regions.RegionManager   
RegionName# Z
 5!      5"      �� 5$   
   -   5         ��Name$ 
MainRegion��5$      !   ProfesionalShellMainRegion# Z 5%      $��2��5&      $��5,0,5,5q�5'       �� SelectedIndex$ 0��5(      5)      5*      