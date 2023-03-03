using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Icons;

public class Icon : Control {
    public IconType Kind {
        get { return (IconType)GetValue(KindProperty); }
        set { SetValue(KindProperty, value); }
    }
    public Geometry SelectedGeometry {
        get { return (Geometry)GetValue(SelectedGeometryProperty); }
        set { SetValue(SelectedGeometryProperty, value); DefineGeometry(); }
    }
    public Geometry RoundedOutlineGeometry {
        get { return (Geometry)GetValue(RoundedOutlineGeometryProperty); }
        set { SetValue(RoundedOutlineGeometryProperty, value); }
    }
    public Geometry RoundedFilledGeometry {
        get { return (Geometry)GetValue(RoundedFilledGeometryProperty); }
        set { SetValue(RoundedFilledGeometryProperty, value); }
    }
    public Geometry SharpOutlineGeometry {
        get { return (Geometry)GetValue(SharpOutlineGeometryProperty); }
        set { SetValue(SharpOutlineGeometryProperty, value); }
    }
    public Geometry SharpFilledGeometry {
        get { return (Geometry)GetValue(SharpFilledGeometryProperty); }
        set { SetValue(SharpFilledGeometryProperty, value); }
    }

    public double Size {
        get { return (double)GetValue(SizeProperty); }
        set { SetValue(SizeProperty, value); }
    }
    public Brush Color {
        get { return (Brush)GetValue(ColorProperty); }
        set { SetValue(ColorProperty, value); }
    }
    public bool Rounded {
        get { return (bool)GetValue(RoundedProperty); }
        set { SetValue(RoundedProperty, value); }
    }
    public bool Filled {
        get { return (bool)GetValue(FilledProperty); }
        set { SetValue(FilledProperty, value); }
    }

    public static readonly DependencyProperty KindProperty =
        DependencyProperty.Register("Kind", typeof(IconType), typeof(Icon), new PropertyMetadata(IconType.icon_home));
    public static readonly DependencyProperty SizeProperty =
        DependencyProperty.Register("Size", typeof(double), typeof(Icon), new PropertyMetadata(48.0));
    public static readonly DependencyProperty ColorProperty =
        DependencyProperty.Register("Color", typeof(Brush), typeof(Icon), new PropertyMetadata(Brushes.Aqua));
    public static readonly DependencyProperty RoundedProperty =
        DependencyProperty.Register("Rounded", typeof(bool), typeof(Icon), new PropertyMetadata(true));
    public static readonly DependencyProperty FilledProperty =
        DependencyProperty.Register("Filled", typeof(bool), typeof(Icon), new PropertyMetadata(false));

    public static readonly DependencyProperty RoundedOutlineGeometryProperty =
        DependencyProperty.Register("RoundedOutlineGeometry", typeof(Geometry), typeof(Icon), new PropertyMetadata(Geometry.Empty));
    public static readonly DependencyProperty RoundedFilledGeometryProperty =
        DependencyProperty.Register("RoundedFilledGeometry", typeof(Geometry), typeof(Icon), new PropertyMetadata(Geometry.Empty));
    public static readonly DependencyProperty SharpOutlineGeometryProperty =
        DependencyProperty.Register("SharpOutlineGeometry", typeof(Geometry), typeof(Icon), new PropertyMetadata(Geometry.Empty));
    public static readonly DependencyProperty SharpFilledGeometryProperty =
        DependencyProperty.Register("SharpFilledGeometry", typeof(Geometry), typeof(Icon), new PropertyMetadata(Geometry.Empty));
    public static readonly DependencyProperty SelectedGeometryProperty =
        DependencyProperty.Register("SelectedGeometry", typeof(Geometry), typeof(Icon), new PropertyMetadata(Geometry.Empty));

    static Icon() {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(Icon), new FrameworkPropertyMetadata(typeof(Icon)));
    }

    protected override void OnInitialized(EventArgs e) {
        DefineGeometry();
        base.OnInitialized(e);
    }

    protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e) {
        base.OnPropertyChanged(e);
        if (e.Property == KindProperty) {
            DefineGeometry();
        }
    }

    private void DefineGeometry() {
        string outline_rounded_key = $"{Kind}_outline_rounded";
        string filled_rounded_key = $"{Kind}_filled_rounded";
        string outline_sharp_key = $"{Kind}_outline_sharp";
        string filled_sharp_key = $"{Kind}_filled_sharp";

        RoundedOutlineGeometry = Geometry.Parse(IconsCollection.Icons[outline_rounded_key]);
        RoundedFilledGeometry = Geometry.Parse(IconsCollection.Icons[filled_rounded_key]);
        SharpOutlineGeometry = Geometry.Parse(IconsCollection.Icons[outline_sharp_key]);
        SharpFilledGeometry = Geometry.Parse(IconsCollection.Icons[filled_sharp_key]);

    }
}
