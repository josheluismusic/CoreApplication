   M S B A M L   `   `   `  ����P  LCoreApplication.Shell, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:CoreApplication.Shell.UserControls"CoreApplication.Shell.UserControls  5      S.clr-namespace:CoreApplication.Shell.SampleData CoreApplication.Shell.SampleData  5      /    )CoreApplication.Shell.UserControls.Header   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      ?uc0clr-namespace:CoreApplication.Shell.UserControls     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      =sd.clr-namespace:CoreApplication.Shell.SampleData     5      -   5          >�Name$
  Root��5      .��5      �    MenuBackgroundColor#���   6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   o� $��0��6     	MenuStyle#���  5       � DataContext 5      �� *
MainMenu+ �� ElementName$
 Root����5      �� 5      o� 5   
   $��1��6     MenuButtonStyle#���  5      .@�5      m�   MenuButtonItemStyle#���  5        5      �� *	StatsMenu+$
 Root����5      ��  m� Icon 5!      �� 5"      $'��!..\Resources\ico-estadisticas.png��6   5$      m� 5%      #���  5(       5%      �� *
ConfigMenu+$
 Root����5'      ��  5)      �� 5*      $'��!..\Resources\ico-herramientas.png��6   5,      m� 5-      #���  50       5-      �� *
HelpMenu+$
 Root����5/      ��  51      �� 52      $��..\Resources\ico-faq.png��6   54      m� 55      -   5         m�Name$ 
SearchMenu��55      #���  56       57      �� 58      $!��..\Resources\ico-buscar.png��6   .@�5:      m� -   5        $ Results��5:       # MenuSearchSubmenuHeaderTemplate#���  5;      #���  5<      ��5=      �� 5>       �� Orientation$ 
Horizontal=�6%   .+�5?      �� -   5         ��Name$ Query��5?   &   $	��200��5@   &     MenuFontSizeSubmenu#���  5A   &   $��0q�5B   &   5C      5E      5F      5G      �� 5J   
   $��2��6   $��	15,0,15,0q�5K      $	��165��5L      $��37��5M      $$��..\Resources\logo-alemanab.png��5N      5O      5P      