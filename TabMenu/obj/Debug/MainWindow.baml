   M S B A M L   `   `   `  ����B  >TabMenu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:TabMenuTabMenu  5   	       TabMenu.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   !localclr-namespace:TabMenu  5   	   -   5        $	��600��5      $
��1080��6'     � 
ResizeMode$  NoResize=�64    � WindowStartupLocation$ CenterScreen=�6J    � WindowStyle$
 None=�6o   .��5	      �� 
�������.+�5
   
   � $��40��6   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��Right=�62   $
��20 0q�6N   .+�5      �� -   5        $
��Exit��5      $��Center=�6R    0  ,MaterialDesignFloatingActionMiniAccentButton#��[  6m   ��6%   Z� ��6;   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=null]]   Kind$ Power=�6.   ���	#FFA2A2A2$��25��6R   $��25��6]   5      5      �� 5      -   5        $��Title��5      $��TOP 250 IMDB MOVIES��6!   $
��Left=�6?   $	��Top=�6Z   $��40��6r   $	��235��6~   $��Times New Roman)�6�   $��20(�6�   ���	#FF2196F3��6�   Z� ��6�   Z� 5      5      � 5   
   $	��100��6   .+�5      �� $ 
Horizontal=�6   $	��Top=�62   $
��10 0q�6J   .+�5      �� -   5        
 J� Uid$ 0��5      $	��150��6!   $
��HOME��6-   $��50��6<   ���	#FF2196F3��6H   Z� ��6^   Z� 6�   �� 5      -   5        $ 1��5      $	��150��6!   $��DOWNLOAD��6-   $��50��6@   ���	#FF2196F3��6L   Z� ��6b   Z� 6�   �� 5      -   5        $ 2��5      $	��150��6!   $��SEARCH��6-   $��50��6>   ���	#FF2196F3��6J   Z� ��6`   Z� 6�   �� 5      -   5        $ 3��5      $	��150��6!   $
��HELP��6-   $��50��6<   ���	#FF2196F3��6H   Z� ��6^   Z� 6�   �� 5      -   5        $��PrintButton��5   �   $ 4��6   $	��150��6!   $��PRINT TO FILE��6-   $��50��6E   ���	#FF2196F3��6Q   Z� ��6g   Z� 6�   5      � 5      -	   5         �Name$ 
GridCursor��5      $	��150��6'   $��5��63   ���	#FF2196F3$
��Left=�6U   $
��10 0q�6p   5       � 5   
   -
   5          �Name$ Frame��5      $	��460��6   
������  � NavigationUIVisibility$ Hidden=�6Z   5      &   System.Windows.Controls.DataGrid  5    
   $	��100��6    � 5!   
   $��Frame��6   $	��100��6    5"      5#      